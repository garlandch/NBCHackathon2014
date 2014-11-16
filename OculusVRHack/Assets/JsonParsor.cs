using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace testhttp
{
	class JsonParsor
	{
		public static Dictionary<string,string> JsonParse(String rawJson)
		{
			List<Dictionary<string,string>> items = new List<Dictionary<string, string>>();
			Dictionary<string, string> outdict = new Dictionary<string, string>();
			StringBuilder keybufferbuilder = new StringBuilder();
			StringBuilder valuebufferbuilder = new StringBuilder();
			StringReader bufferreader = new StringReader(rawJson);
			int s = 0;
			bool reading = false;
			bool inside_string = false;
			bool reading_value = false;
			bool reading_number = false;
			while (s >= 0)
			{
				s = bufferreader.Read();
				if (!reading)
				{
					if ((char)s == '{' && !inside_string && !reading)
					{
						reading = true;
						continue;
					}
					if ((char)s == '}' && !inside_string && !reading)
						break;
					if ((char)s == ']' && !inside_string && !reading)
						continue;
					if ((char)s == ',')
						continue;
				}
				else
				{
					if (reading_value)
					{
						if (!inside_string && (char)s >= '0' && (char)s <= '9')
						{
							reading_number = true;
							valuebufferbuilder.Append((char)s);
							continue;
						}
					}
					//if we find a quote and we are not yet inside a string, advance and get inside
					if (!inside_string)
					{
						if ((char)s == '\"' && !inside_string)
							inside_string = true;
						if ((char)s == '[' && !inside_string)
						{
							keybufferbuilder.Length = 0;
							valuebufferbuilder.Length = 0;
							reading = false;
							inside_string = false;
							reading_value = false;
						}
						if ((char)s == ',' && !inside_string && reading_number)
						{
							if (!outdict.ContainsKey(keybufferbuilder.ToString()))
								outdict.Add(keybufferbuilder.ToString(), valuebufferbuilder.ToString());
							keybufferbuilder.Length = 0;
							valuebufferbuilder.Length = 0;
							reading_value = false;
							reading_number = false;
						}
						continue;
					}
					
					//if we reach end of the string
					if (inside_string)
					{
						if ((char)s == '\"')
						{
							inside_string = false;
							s = bufferreader.Read();
							if ((char)s == ':')
							{
								reading_value = true;
								continue;
							}
							if (reading_value && (char)s == ',')
							{
								//Console.WriteLine( keybufferbuilder.ToString() + " : " +valuebufferbuilder.ToString());
								//put the key-value pair into dictionary
								if (!outdict.ContainsKey(keybufferbuilder.ToString()))
									outdict.Add(keybufferbuilder.ToString(), valuebufferbuilder.ToString());
								items.Add(outdict);
								keybufferbuilder.Length = 0;
								valuebufferbuilder.Length = 0;
								reading_value = false;
							}
							if (reading_value && (char)s == '}')
							{
								if (!outdict.ContainsKey(keybufferbuilder.ToString()))
									outdict.Add(keybufferbuilder.ToString(), valuebufferbuilder.ToString());
								ICollection key = outdict.Keys;
								//DataRow newrow = dataTable.NewRow();
								//foreach (string k_loopVariable in key)
								//{
									//CommonModule.LogTheMessage(outdict[k_loopVariable],"","","");
									//newrow[k_loopVariable] = outdict[k_loopVariable];
									//Console.WriteLine(outdict[k_loopVariable]);
								//}
								//dataTable.Rows.Add(newrow);
								//CommonModule.LogTheMessage(dataTable.Rows.Count.ToString(), "", "row_count", "");
								items.Add(outdict);
								//outdict.Clear();
								keybufferbuilder.Length=0;
								valuebufferbuilder.Length=0;
								reading_value = false;
								reading = false;
								continue;
							}
						}
						else
						{
							if (reading_value)
							{
								valuebufferbuilder.Append((char)s);
								continue;
							}
							else
							{
								keybufferbuilder.Append((char)s);
								continue;
							}
						}
					}
					else
					{
						switch ((char)s)
						{
						case ':':
							reading_value = true;
							break;
						default:
							if (reading_value)
							{
								valuebufferbuilder.Append((char)s);
							}
							else
							{
								keybufferbuilder.Append((char)s);
							}
							break;
						}
					}
				}
			}
			return outdict;
		}
	}
}
