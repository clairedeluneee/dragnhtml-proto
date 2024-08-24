namespace Utils;

public static class BuilderFunctions {
    public static int CurrentDepth = 0;
    private static int LineCount = 0;
    private static string TabDepth = "";
    public static string EncloseWithTags(string tag, string contents) {
        UpdateTabDepth();
        return increm(TabDepth + "<" + tag + "> " + contents + " </" + tag + ">");
    }
    public static string BeginStructureTag(string structTag) {
        CurrentDepth++;
        UpdateTabDepth();
        return increm(TabDepth + "<" + structTag + ">");
    }
    public static string EndStructureTag(string structTag) {
        UpdateTabDepth();
        CurrentDepth--;
        return increm(TabDepth + "<" + structTag + ">");
    }

    public static void UpdateTabDepth() {
        if (CurrentDepth == 0) return;
        TabDepth = ""; // reset tab depth
        for (int i = 0; i < CurrentDepth; i++)
        {
            TabDepth += "\t";
        }
    }
    private static string increm(string thing) {
        LineCount++;
        return LineCount + "\t" + thing;
    }
}

