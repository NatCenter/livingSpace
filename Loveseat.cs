using System;
namespace livingSpace
{
    public class Loveseat:Furniture,ISeating
    {
        public int  Seating{get;set;}
        
        public int Pillows {get;set;}

         public override void  furnitureInfo (){
            Console.WriteLine("Info about the Love seat");
            
        }
    }

}