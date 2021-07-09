export function repeatStr(n: number, s: string): string {
  if (n==0) return '';
  let result:string='';
  for (let i=0; i<n;i++)
    result=result.concat(s);
  return result;
}