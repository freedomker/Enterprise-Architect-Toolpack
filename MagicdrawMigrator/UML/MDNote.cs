﻿using System.Collections.Generic;
using System.Linq;
using System;

namespace MagicdrawMigrator
{
	/// <summary>
	/// Description of MDNote.
	/// </summary>
	public class MDNote
	{
		public string text {get;set;}
		public string linkedElement {get;set;}
		public int x {get;private set;}
		public int y {get;private set;}
		public int right {get;private set;}
		public int bottom {get;private set;}
		string _geometry;
		public MDDiagram mdDiagram {get;set;}
		
		public MDNote(string text,string linkedElement, MDDiagram mdDiagram, string geometry)
		{
			this.text = text;
			this.linkedElement = linkedElement;
			this.mdDiagram = mdDiagram;
			this.geometry = geometry;
		}
		
		
		public string geometry {
			get {
				return _geometry;
			}
			set {
				_geometry = value;
				//set the individual parts
				int _x;
				int _y;
				int _right;
				int _bottom;	
				//sometimes there a ";" that seperates start and end points.
				// we are not interested in that so we replace that by a "," so everything can be treated the same way.
				this._geometry = _geometry.Replace(';',',');
				var parts = _geometry.Split(',');
				x = parts.Count() >= 1 && int.TryParse(parts[0],out _x) ? _x : 0;
				y = parts.Count() >= 2 && int.TryParse(parts[1],out _y) ?  _y : 0;
				right = parts.Count() >= 3 && int.TryParse(parts[2],out _right) ? _right : 0;
				bottom = parts.Count() >= 4 && int.TryParse(parts[3],out _bottom) ? _bottom : 0;
			}
		}
		
		

	}
}
