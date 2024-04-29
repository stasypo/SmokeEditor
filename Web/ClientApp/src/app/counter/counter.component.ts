import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public six = 6;

  public incrementCounter(amount: number) {
    this.currentCount++;
  }
}
