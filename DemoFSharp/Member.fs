module Member

type Region() =
  let mutable t = 0.0f
  member val Width = 0.0f
  member x.Height = 0.0f
  member val Left = 0.0f with get,set
  member x.Top with get() = 0.0f and set(value) = t <- value

  // Same as
  (*
  public class Region
  {
      internal float t;  
      internal float Width@;
      internal float Left@; 
      public float Width
      {
          get
          {
              return this.Width@;
          }
      } 
      public float Height
      {
          get
          {
              return 0f;
          }
      }  
      public float Left
      {
          get
          {
              return this.Left@;
          }
          set
          {
              this.Left@ = value;
          }
      }  
      public float Top
      {
          get
          {
              return 0f;
          }
          set
          {
              this.t = value;
          }
      }  
      public Region() : this()
      {
          this.t = 0f;
          this.Width@ = 0f;
          this.Left@ = 0f;
      }
  }
  *)