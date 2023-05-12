import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-filter-button',
  templateUrl: './filter-button.component.html',
  styleUrls: ['./filter-button.component.scss']
})
export class FilterButtonComponent {
  @Input() TipButon : string = '';
  @Output() checkedValuesButton = new EventEmitter<string[]>();
  filtersReg : string[];
  filtersTip : string[];
  filters : string[];


  onCheckboxChange(): void {
    const checkedValues: string[] = [];
    if(this.TipButon === 'Regiune')
    {
      const checkboxes: HTMLInputElement[] = Array.from(document.querySelectorAll('#flexCheckReg:checked'));
      checkboxes.forEach((checkbox) => checkedValues.push(checkbox.value));
      this.filters = checkedValues;
      this.filters.push("Regiune");
    }
    else if(this.TipButon === 'Tip')
    {
      const checkboxes: HTMLInputElement[] = Array.from(document.querySelectorAll('#flexCheckTip:checked'));
      checkboxes.forEach((checkbox) => checkedValues.push(checkbox.value));
      this.filters = checkedValues;
      this.filters.push("Tip");
    }
  }

  emitValues()
  {
    this.checkedValuesButton.emit(this.filters);
  }


}

