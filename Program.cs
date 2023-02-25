string degisken = "Tiyatromuza hoş geldiniz.";
string degisken2 = "Oyun";
// Length
Console.WriteLine(degisken.Length);

// ToUpper, ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// Concat
Console.WriteLine(String.Concat(degisken," Merhaba!"));

// Compare, CompareTo

Console.WriteLine(degisken.CompareTo(degisken2)); //0,-1,1
Console.WriteLine(String.Compare(degisken,degisken2,true));
Console.WriteLine(String.Compare(degisken,degisken2,false));

// Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("geldiniz."));
Console.WriteLine(degisken.StartsWith("Tiyatro"));

//IndexOf
Console.WriteLine(degisken.IndexOf("ho"));
Console.WriteLine(degisken.IndexOf("meltem"));
Console.WriteLine(degisken.LastIndexOf("o"));

// Insert
Console.WriteLine(degisken.Insert(0,"Merhaba ")); // 0. karakterden sonra ekle

//PadLeft, PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

// Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1)); //0. indexten başla 1 karakter sil

// Replace
Console.WriteLine(degisken.Replace("hoş","boş"));
Console.WriteLine(degisken.Replace(" ","*"));

// Split
Console.WriteLine(degisken.Split(' ')[1]);

// Substring
Console.WriteLine(degisken.Substring(4)); ///4. indexten başlayıp sonuna kadar getir
Console.WriteLine(degisken.Substring(4,6)); //4. indexten başlayıp 6 karakter getir