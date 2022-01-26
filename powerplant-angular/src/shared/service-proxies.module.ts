import * as Apis from './service-proxies';
import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';


@NgModule({
  providers: [
    Apis.ApiServiceProxy,
  ]
})
export class ServiceProxiesModule {
}
