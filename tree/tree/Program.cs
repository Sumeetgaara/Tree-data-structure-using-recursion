using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Input> InputList = new List<Input>();
			Input i1 = new Input();
			i1.ID = 1;
			i1.Val = "one";
			i1.Parent = 0;
			InputList.Add(i1);
			//
			Input i2 = new Input();
			i2.ID = 2;
			i2.Val = "two";
			i2.Parent = 1;
			InputList.Add(i2);
			//
			Input l1 = new Input();
			l1.ID = 8;
			l1.Val = "eight";
			l1.Parent = 1;
			InputList.Add(l1);
			//
			Input i3 = new Input();
			i3.ID = 5;
			i3.Val = "five";
			i3.Parent = 1;
			InputList.Add(i3);
			//
			Input i4 = new Input();
			i4.ID = 3;
			i4.Val = "three";
			i4.Parent = 2;
			InputList.Add(i4);
			//
			Input i5 = new Input();
			i5.ID = 4;
			i5.Val = "four";
			i5.Parent = 2;
			InputList.Add(i5);
			//
			Input i6 = new Input();
			i6.ID = 6;
			i6.Val = "six";
			i6.Parent = 4;
			InputList.Add(i6);
			//
			Input i7 = new Input();
			i7.ID = 7;
			i7.Val = "Seven";
			i7.Parent = 2;
			InputList.Add(i7);
			//
			//
			Input i8 = new Input();
			i8.ID = 9;
			i8.Val = "Nine";
			i8.Parent = 8;
			InputList.Add(i8);

			List<TreeView> treeDS = new List<TreeView>();
			foreach(var obj in InputList)
			{
				TreeView tobj = new TreeView();
				tobj.Children = new List<TreeView>();
				if(obj.Parent == 0)
				{
					tobj.Value = obj.ID;
					tobj.Name = obj.Val;
					treeDS.Add(tobj);
				}
				else
				{
					var parentobj = FindParent(treeDS.First(), obj.Parent);
					tobj.Value = obj.ID;
					tobj.Name = obj.Val;
					parentobj.Children.Add(tobj);

				}
			}


			Console.ReadKey();
		}

		public static TreeView FindParent(TreeView node , int paramValue)
		{
			if(node.Value == paramValue)
			{
				return node;
			
			}
			else
			{
				foreach (var val in node.Children)
				{
					var found= FindParent(val, paramValue);
					if(found!=null)
					{
						return found;

					}
				}
				return null;

			}
		}

		}

	class TreeView
	{
		public int Value { get; set; }
		public string Name { get; set; }
		public List<TreeView> Children { get; set; }
	}

	class Input
	{
		public int ID { get; set; }
		public string Val { get; set; }
		public int Parent { get; set; }

	}


	}
