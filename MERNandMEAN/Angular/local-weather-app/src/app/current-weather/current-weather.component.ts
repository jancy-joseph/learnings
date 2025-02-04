import { Component, OnInit } from '@angular/core';
import { ICurrentWeather } from '../icurrent-weather';

@Component({
  selector: 'app-current-weather',
  templateUrl: './current-weather.component.html',
  styleUrls: ['./current-weather.component.css']
})
export class CurrentWeatherComponent implements OnInit {
 current:ICurrentWeather
  constructor() { 
    this.current ={
      city:'Chicago',
      country:'US',
      date:new Date(),
      image:'',
      temperature:61,
      description:'Sunny'
    }
  }

  ngOnInit(): void {
  }

}
