// AdventOfCode Tag4

string Testinput = @"..@@.@@@@.
@@@.@.@.@@
@@@@@.@.@@
@.@@@@..@.
@@.@@@@.@@
.@@@@@@@.@
.@.@.@.@@@
@.@@@.@@@@
.@@@@@@@@.
@.@.@@@.@.";

static List<string> SplitInput(string input)
{
    List<string> output = input.Split('\n').ToList();
    return output;
}

static int FindForkLiftAccessibleRollsOfPaper(List<string> input)
{
   // int[,] WallOfPaperRolls = new int[input[0].Length, input.Count];
    List<(int,int)> ForkliftForkSpace = new List<(int, int)>()
    {
        (-1,-1),(-1,0),(-1,1),(0,-1),(0,1),(1,-1),(1,0),(1,1)
    };
        
    
    foreach (string RowOfPaperRolls in input)
    {
      int RowIndex = input.IndexOf(RowOfPaperRolls);
      foreach (char PaperRollSlot in RowOfPaperRolls)
        {
            if (PaperRollSlot == '@')
            {
                int SlotIndex = RowOfPaperRolls.IndexOf(PaperRollSlot);

            }
        }
    }
}