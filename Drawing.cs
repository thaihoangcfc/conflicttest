﻿using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
	public class Drawing
	{
		private readonly List<Shape> _shapes;
		private Color _background;

		public Color Background {
			get {
				return _background;
			}

			set {
				_background = value;
			}
		}

		public Drawing (Color background)
		{
			_shapes = new List<Shape> ();
			_background = background;
		}

		public Drawing () : this (Color.White)
		{ 
		}

		public int ShapeCount {
			get {
				return _shapes.Count;
			}
		}

		public List<Shape> Shapes {
			get {
				return _shapes;
			}
		}

		public void AddShape (Shape shape)
		{
			_shapes.Add (shape);
		}

		public void Draw ()
		{
			foreach (Shape shape in _shapes)
			{
				shape.Draw ();
			}
		}


		/*public List<Shape> SelectedShapes {
			get {
				List<Shape> result = new List<Shape> ();
				foreach (Shape s in _shapes) {
					if (s.Selected == true) {
						result.Add (s);
					}
				}
				return result;
			}
		}*/

		public void RemoveShape (List<Shape> Remove)
		{
			foreach (Shape s in Remove) {
				_shapes.Remove (s);
			}
		}

	}
}
