import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceProxiesModule } from 'src/shared/service-proxies.module';
import { API_BASE_URL } from 'src/shared/service-proxies';
import { FormsModule } from '@angular/forms';


export function getRemoteServiceBaseUrl(): string {
  return 'https://localhost:44354';
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ServiceProxiesModule
  ],
  providers: [
    { provide: API_BASE_URL, useFactory: getRemoteServiceBaseUrl },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
