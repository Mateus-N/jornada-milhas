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
export class SeletorPassageirosComponent implements ControlValueAccessor {

  @Input()
  titulo: string = ''
  @Input()
  subtitulo: string = ''

  value: number = 0
  onChange = (val: number) => {}
  onTouch = () => {}

  writeValue(val: any): void {
    this.value = val
  }
  registerOnChange(fn: any): void {
    this.onChange = fn
  }
  registerOnTouched(fn: any): void {
    this.onTouch = fn
  }
  setDisabledState?(isDisabled: boolean): void {

  }

  incrementar() {
    this.value += 1
    this.onChange(this.value)
    this.onTouch()
  }

  decrementar() {
    if (this.value > 0) {
      this.value -= 1
      this.onChange(this.value)
      this.onTouch()
    }
  }
}
