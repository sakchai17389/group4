import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

/*
  Generated class for the CallApiProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class CallApiProvider {

  constructor(public http: HttpClient) {
    console.log('Hello CallApiProvider Provider');
  }
  public Getallproduct(){
    return this.http.get('https://localhost:5001/api/product/Getallproduct');
  }
 public GetproductID(id: string){
    return this.http.get('https://localhost:5001/api/product/Getproduct/' + id);
  }
  public Createproduct(newProduct: string){
    return this.http.get('https://localhost:5001/api/product/Createproduct/', newProduct);
  }
}
