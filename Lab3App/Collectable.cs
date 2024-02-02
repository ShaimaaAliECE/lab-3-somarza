using System;
using System.Collections.Generic;
namespace Lab3App
{
	internal abstract class Collectable : Displayable
	{
		public string Description { get; set; }
		public CollectionBoard Board { get; set; }//create a field type Collection Board
		public abstract void Display();
		public abstract void AddMe(List<Collectable> collection);
	}
}

