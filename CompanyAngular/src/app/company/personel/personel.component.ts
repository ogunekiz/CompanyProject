import { Component, OnInit } from '@angular/core';
import { Personel } from 'src/app/models/personel';
import { PersonelService } from 'src/app/services/personel.service';

@Component({
  selector: 'app-personel',
  templateUrl: './personel.component.html',
  styleUrls: ['./personel.component.css']
})
export class PersonelComponent implements OnInit {

  personelList: Personel[] = [];

  constructor(private personelService: PersonelService) { }

  ngOnInit(): void {

    this.getPersonelData();

    this.personelService.onUpdatePersonelList(() => {
      this.getPersonelData();
    })
  }

  getPersonelData() {
    this.personelService.getPersonelData().subscribe((data) => {
      this.personelList = data;
    });
  }

}
