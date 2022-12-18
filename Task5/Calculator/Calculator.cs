public class Calculator{
    public long Factorial(long n){
        long sum=1;
        for(int i=1;i<=n;i++){
            sum=sum*i;
        }
        return (long)sum;
    }

    public double Multiple(double a, double b){
        return a*b;
    }
    public double Division(int a, int b){
        return a/b;
    }
}