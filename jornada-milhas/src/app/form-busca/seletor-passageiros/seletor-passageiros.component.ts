import { Component, Input, forwardRef } from '@angular/core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'app-seletor-passageiros',
  templateUrl: './seletor-passageiros.component.html',
  styleUrls: ['./seletor-passageiros.component.scss'],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => SeletorPassageirosComponent),
      multi: true
    }
  ]
})
export class SeletorPassageirosComponent implements ControlValueAccessor{

  @Input()
  titulo = '';
  @Input()
  subtitulo = '';

  value = 0;
  onChange = (val: number) => {throw new Error(`Method not implemented. ${val}`);};
  onTouch = () => {throw new Error(`Method not implemented.`);};

  writeValue(val: number): void {
    this.value = val;
  }
  registerOnChange(fn: ()=> never): void {
    this.onChange = fn;
  }
  registerOnTouched(fn: ()=> never): void {
    this.onTouch = fn;
  }

  incrementar() {
    this.value += 1;
    this.onChange(this.value);
    this.onTouch();
  }

  decrementar() {
    if (this.value > 0) {
      this.value -= 1;
      this.onChange(this.value);
      this.onTouch();
    }
  }
}
