using System;
using System.Collections.Generic;
using System.IO;

namespace StringFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Frequency");

            try
            {
                StreamReader streamReader;
                Dictionary<string, int> hashtable = new Dictionary<string, int>();
                using (streamReader = new StreamReader("test.txt"))
                {
                    string[] words;
                    string input = streamReader.ReadToEnd();
                    input = input.Replace(Environment.NewLine, " ");
                    input = input.Replace("\t", " ");
                    while (input.Contains("  "))
                    {
                        input = input.Replace("  ", " ");
                    }
                    words = input.Split(" ");
                    foreach (string word in words)
                    {
                        int value;
                        if (hashtable.TryGetValue(word, out value))
                        {
                            value = hashtable[word];
                            hashtable.Remove(word);
                            hashtable.Add(word, value + 1);
                        }
                        else
                        {
                            hashtable.Add(word, 1);
                        }
                    }
                }

                StreamWriter streamWriter;
                using (streamWriter = new StreamWriter("result.txt"))
                {
                    string[] keys = new string[hashtable.Count];
                    hashtable.Keys.CopyTo(keys, 0);
                    int[] values = new int[hashtable.Count];
                    hashtable.Values.CopyTo(values, 0);

                    Array.Sort(values, keys);
                    for (int i = keys.Length - 1; i >= 0; i--)
                    {
                        streamWriter.WriteLine("Tu: {0,-20} \t- Lap lai: {1}", keys[i], values[i]);
                    }
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    
}