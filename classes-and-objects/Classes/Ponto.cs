namespace classes_and_objects.Classes
{
  public class Ponto
  {
    public int x;
    public int y;

    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protected int calculateDistance(int x, int y)
    {
      if (x > y)
      {
        return x - y;
      }
      return y - x;
    }

    public int multiplyDistance(int point, int mult)
    {
      return point * mult;
    }

    public static int duplicateDistance(int point) {
        return point * 2;
    }
  }
}