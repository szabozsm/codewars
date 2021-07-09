export function noSpace(x:string):string {
  // Your Code
    let result = '';
    for (let i=0;i<x.length;i++)
    {
      if (x[i]!=' ')
        result+=x[i];
    }
  return result;
}