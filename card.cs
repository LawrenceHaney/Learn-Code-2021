namespace Set{
    public static class card {
      public int number;
      public string symbol;
      public string shading;
      public string color;

      public function IEnumerator<PropertyInfo> getProps {
          foreach(var property in typeof(card).GetProperties())
            {
                yield return property;
            }
      }
    }
}