public class FindMin{
    public int FindMinimum(int a, int b, int c, int d){
         int min=999999;
        if(a<=min){
           min=a;
        }
        if(b<=min){
        min=b;
        }
        if(c<min){
            min=c;
        }
        if(d<min){
            min=d;
        }
        return min;
    }
}