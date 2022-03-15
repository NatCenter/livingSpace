using System;
namespace livingSpace
{
    public interface ITable
    {
        public string dinning {set;get;}
        public int width {get;set;}
        public int length {get;set;}
        public int height {get;set;}
        public bool ReplaceLegs{get;set;}

        
    }

}