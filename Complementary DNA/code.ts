export class Kata {
  static dnaStrand(dna: string) {
    //your code here
    
    let result = '';
     for (let i=0;i<dna.length;i++)
    {
      let c= '';
      
      if ( dna[i]=="T")
        c="A";
      else
      if ( dna[i]=="A")
        c="T";
      else
      if ( dna[i]=="G")
        c="C";
      else
      if ( dna[i]=="C")
        c="G";
      
        
      
      result=result.concat(c);
      
    }
 
   
    return result;
  }
}