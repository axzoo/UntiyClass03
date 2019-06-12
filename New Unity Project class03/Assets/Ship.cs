public class Ship
{
    public float speed;
    //public float width { get; }

    public float length { get; set; }

    //public int password { set; }

    //get (only read);set (only write <might get fail>)

    private float width = 12.4f;
    private float _width;

    private float _height = 4.3f;
    public float height { get => _height; set => _height = value; }

    private float _volume;
    public float volume
    {
        get
        {
            _volume = length * width * height;
            return _volume;
        }

    }


    public float Width { get { return _width; } }


    
}
