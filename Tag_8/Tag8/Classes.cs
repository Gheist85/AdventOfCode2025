public class JunctionBox
{
    public int x {get; set;}
    public int y {get; set;}
    public int z {get; set;}

    public List<JunctionBox> ConnectedJunctionBoxes {get; set;}

    public JunctionBox ()
    {
        ConnectedJunctionBoxes = new List<JunctionBox>();
    }

}

public class Circuit
{
    public List<JunctionBox> ContainedJunctionBoxes {get; set;}

    public Circuit ()
    {
        ContainedJunctionBoxes = new List<JunctionBox>();
    }
}