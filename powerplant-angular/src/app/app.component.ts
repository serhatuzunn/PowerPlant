import { Component } from '@angular/core';
import { ApiServiceProxy, ElectroMeter } from 'src/shared/service-proxies';
import { ElectrometerModel } from './Models/ElectrometerModel';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  posts: ElectroMeter[] = [];
  electroMeterName: string = '';
  electroMeterWebId : string = '';
  constructor(private api: ApiServiceProxy) {}

  ngOnInit() {
    this.getAllElectroMeters();
  }

  async getAllElectroMeters() {
    this.posts = await this.api.getAll().toPromise();
  }

  async onUpdateClick(item:ElectroMeter){
    this.electroMeterName = item.name;
    this.electroMeterWebId = item.webid;
  }

  async onSaveChangesClick() : Promise<void> {
    await this.api.save(this.electroMeterName).toPromise();
    await this.getAllElectroMeters();
  }

  async updateElectroMeter() {
    await this.api.update(this.electroMeterName,this.electroMeterWebId).toPromise();
    await this.getAllElectroMeters();
  }

  async deleteElectroMeter(item:ElectroMeter) {
    this.electroMeterWebId = item.webid;
    await this.api.delete(this.electroMeterWebId).toPromise();
    await this.getAllElectroMeters();
  }

}
