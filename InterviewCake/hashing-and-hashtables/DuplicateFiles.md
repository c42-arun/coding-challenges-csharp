You left your computer unlocked and your friend decided to troll you by copying a lot of your files to random spots all over your file system.

Even worse, she saved the duplicate files with random, embarrassing names ("this_is_like_a_digital_wedgie.txt" was clever, I'll give her that).

Write a method that returns an array of all the duplicate files. We'll check them by hand before actually deleting them, since programmatically deleting files is really scary. To help us confirm that two files are actually duplicates, return an array of FilePaths objects with properties for the original and duplicate paths:

public class FilePaths
{
    public string DuplicatePath { get; }

    public string OriginalPath { get; }

    public FilePaths(string duplicatePath, string originalPath)
    {
        DuplicatePath = duplicatePath;
        OriginalPath = originalPath;
    }

    public override string ToString()
    {
        return $"(original: {OriginalPath}, duplicate: {DuplicatePath})";
    }
}

For example:

[(original: /home/parker/secret_puppy_dance.mpg, duplicate: /tmp/parker_is_dumb.mpg),
 (original: /etc/apache2/httpd.conf, duplicate: /home/trololol.mov)]

You can assume each file was only duplicated once.