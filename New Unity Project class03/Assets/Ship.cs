public class Ship
{
    public float speed;
    //public float width { get; }

    public float length { get; set; }

    //public int password { set; }

    //get (only read);set (only write <might be get fail>)

    private float width = 12.4f;
    private object heigth;
    private float _width;

    private float _height = 4.3f;
    public float height { get => _height; set => _height = value; }
    public string Width { get; internal set; }

    /*private float _volume;
    public float volume
    {
        get
        {
            _volume = length * width * height;
            return _volume;
        }

    }


    public float Width { get { return _width; } }
    */

    private float _volume;
    public float volume;
        
    public Ship(float len, float wid, float hei)
    {
        length = len;
        width = wid;
        heigth = hei;
    }

    public Ship()
    {

    }
}
