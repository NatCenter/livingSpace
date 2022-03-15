using System;
namespace livingSpace
{
    public class Nightstand:Furniture,ITable
    {
         public string dinning {set;get;}
        public int width {get;set;}
        public int length {get;set;}
        public int height {get;set;}
         public bool ReplaceLegs{get;set;}
         public override void  furnitureInfo (){
            Console.WriteLine("Info about the Night stand");
            
        }
    }

}