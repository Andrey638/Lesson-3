//принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите коардинаты точек x,y,z,x1,y1,z1");
 double ab=0;
 double [] point = new double[6];

 for(int i=0;i<point.Length;i++);
     point[i]=Convert.ToDouble(Console.ReadLine());
     ab = Math.Sqrt(Math.Pow(point[0]-point[3],2) + Math.Pow(point[1]-point[4],2) + Math.Pow(point[2]-point[5],2));
 Console.WriteLine(ab);

/* double ab=0;
 double [] point = new double[4];
 for (int i=0; i<point.Length; i++);
 point[i]=Convert.ToDouble(Console.ReadLine());
 ab=Math.Sqrt((point[0]-point[2])*(point[0]-point[2])+(point[1]-point[3])*(point[1]-point[3]));
 Console.WriteLine(ab);*/
