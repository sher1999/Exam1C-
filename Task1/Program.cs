
int n;
n=Convert.ToInt32(Console.ReadLine());
 int[] array =new int[n];
 for(int i=0;i<n;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
 }
 Array.Sort(array);
  int cnt=1;
 for (int i = 0; i<n-1; i++) {
			if (array[i] != array[i+1] ) {
                cnt++;				       
		}      
	}
   System.Console.WriteLine(cnt);
 