export function isIsogram(str: string){
  //...
  if (str=="") return true;
  str=str.toUpperCase();
 
  for (let i=0;i<str.length-1;i++)
    {
      
      for(let j=i+1;j<str.length;j++)
        {
          if (str[j]==str[i])
            return false;
        }
      
      
    }
    
  
  
  return true;
}