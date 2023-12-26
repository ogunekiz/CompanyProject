import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonelComponent } from './company/personel/personel.component';

const routes: Routes = [
  { path: 'personel', component: PersonelComponent },
  { path: '', redirectTo: 'personel', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
