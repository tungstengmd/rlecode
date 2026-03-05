string[] rle = File.ReadAllLines("U:/logartRLE.txt");
string body = "";
for (int i = 0; i<rle.Length; i++) {
    for (int j = 0; j<rle[i].Length; j+=3) body+=new string(rle[i][j+2], Convert.ToInt32(rle[i][j..(j+2)]));
    body+="\n";
}
Console.WriteLine(body);