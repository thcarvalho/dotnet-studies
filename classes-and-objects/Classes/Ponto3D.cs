namespace classes_and_objects.Classes
{
  public class Ponto3D : Ponto
  {
    public int z;
    public Ponto3D(int x, int y, int z) : base(x, y)
    {
      this.x = x;
      this.y = y;
      this.z = z;
    }

    public int calculate3d(int x, int y, int z) {
        return calculateDistance(x, y) * z;
    }
  }
}