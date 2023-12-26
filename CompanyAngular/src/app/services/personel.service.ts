import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { Personel } from '../models/personel';

@Injectable({
  providedIn: 'root'
})
export class PersonelService {
  private hubConnection!: signalR.HubConnection;
  private reconnectionAttemptCount = 0;
  private readonly maxReconnectionAttempts = 100;
  private readonly reconnectionInterval = 5000;

  constructor(private http: HttpClient) {

    this.startConnection();

  }

  private async startConnection() {

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('http://localhost:1616/personelHub')
      .withAutomaticReconnect({
        nextRetryDelayInMilliseconds: () => this.reconnectionInterval
      })
      .build();

    this.hubConnection.start()
      .then(() => {
        console.log('SignalR connected!');
        this.reconnectionAttemptCount = 0;
      })
      .catch(err => {
        console.error('SignalR connection error: ', err);
        this.reconnect();
      });

    this.hubConnection.onclose(() => {
      console.log('SignalR connection closed!');
      this.reconnect();
    });

  }

  private reconnect() {
    if (this.reconnectionAttemptCount < this.maxReconnectionAttempts) {
      console.log(`Reconnecting... Attempt ${this.reconnectionAttemptCount + 1} of ${this.maxReconnectionAttempts}`);
      setTimeout(() => {
        this.reconnectionAttemptCount++;
        this.startConnection();
      }, this.reconnectionInterval);
    } else {
      console.error(`Exceeded maximum reconnection attempts (${this.maxReconnectionAttempts})`);
    }
  }


  onUpdatePersonelList(callback: () => void) {
    this.hubConnection.on('PersonelList', callback);
  }

  getPersonelData() {
    return this.http.get<Personel[]>('http://localhost:1616/api/Personel/GetPersonelList');
  }


}
