using System;
using System.Collections.Generic;
using UnityEngine;

namespace Bm.Drawer
{
    public static class TransformExtensionMethods
	{
		public static string HierarchyName(this Transform transform)
		{
			string text = transform.name;
			while (transform.parent != null)
			{
				text = transform.parent.name + "/" + text;
				transform = transform.parent;
			}
			return text;
		}
	}
}
