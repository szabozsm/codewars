export class Kata {
  static validatePin(pin: string): boolean {
  let   regexp = new RegExp('^[0-9][0-9][0-9][0-9]$|^[0-9][0-9][0-9][0-9][0-9][0-9]$');
    return regexp.test(pin);
  }
}