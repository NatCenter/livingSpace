using System;
using System.Collections.Generic;

namespace livingSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Couch ikea =new Couch();
            ikea.Seating=3;
            ikea.Pillows=10;
            ikea.color="red";
            ikea.brand="ikea";
            ikea.room="lving room";
            Loveseat love=new Loveseat();
            love.Seating=1;
            love.Pillows=2;
            love.color="red";
            List <ISeating> listSeating=new List<ISeating>();
            listSeating.Add(ikea);
            listSeating.Add(love);

            foreach(ISeating listSeat in  listSeating){

                Console.WriteLine($"number of seating {listSeat.Seating} number of pillows {listSeat.Pillows}");
            }

            DiningTable woodTable=new DiningTable();
            woodTable.height=20;
            woodTable.width=20;
            woodTable.length=20;
            woodTable.dinning="wood table";

            Nightstand nightstand=new Nightstand();
            nightstand.height=10;
            nightstand.width=10;
            nightstand.length=10;
            nightstand.dinning="night stand";

            List <ITable> listTable=new List<ITable>();
            listTable.Add(woodTable);
            listTable.Add(nightstand);

            foreach(ITable listingTable in listTable){
                Console.WriteLine($"Table {listingTable.dinning} Width: {listingTable.width} Height:{listingTable.height} Length: {listingTable.length}");
            }

            List <Furniture> listAllfurn=new List<Furniture>();
            listAllfurn.Add(ikea);

             foreach(Furniture list in listAllfurn){
                Console.WriteLine($" The color {list.color} the brand:{list.brand} Where it is in the house {list.room}");
            }
        }
    }
}
