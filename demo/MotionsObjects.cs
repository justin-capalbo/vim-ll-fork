public class MotionsObjects
{
    // Motions and text objects are very powerful ways to navigate + describe your text.

    // MOTIONS

    // Let's say you're trying to put your cursor onto the 'd' in dog to do some
    // editing.  There are a few approaches to get your cursor there, starting from
    // the beginning of the line.
    //   - `hjkl`, tantamount to using the arrow keys.  You would have to do
    //     something like 40-41 presses of l--Or hold down the key.
    //   - `w`, wordwise movement, would get you there in ~9 keystrokes
    //   - `$bb`, end of line -> back 2 words, would get there in 3 (or 4, counting
    //     the shift)
    //   - `fd`, in 2.  :)
    //   - `tdl`, if you're feeling quirky...
    public MotionsObjects()
    {
        var text = "The quick brown fox jumps over the lazy dog.";
    }

    // TEXT OBJECTS

    // Suppose you have some span element in html, and you wish to change the inner
    // content to "bar button" instead of "foo span".  Instead of finicky
    // highlighting with the mouse, you can use `citbar button`:
    //  - `cit` => 'change inner tag'

    // Suppose you want to change the class now, as well.  Simply `f"ci"bar`:
    //  - `f"` => forward to next occurrence of "
    //  - `ci"` => change innner "
    public string ReturnSomeHtml()
    {
        return @"
        <div>
          <span class='foo'>foo span</span>
          <span class='foo'>bar</span>
        </div>
        ";
    }

    // This also works across lines!  While inside the method body, `di{` will empty
    // out the entire method body.  ci{ will do the same thing but immediately enter 
    // insert mode for quick editing. "delete in {".  "delete around {"
    public void Foo()
    {
        var i = "Hello";
        var j = "World";
    }

    // Or to assist with turning Bar() into an abstract method, simply `da{` which will include the
    // { as well.  "delete around {"
    public void Bar()
    {
        var i = "Hello";
        var j = "World";
    }

    // Finally, motions can be used as well to delete from the cursor's current
    // position to the motion's target.  In the below method call, if we are looking
    // to eliminate arg2 and arg3 from the call, we can use `f,df3`:
    //  - `f,` => forward to next occurrence of ,
    //  - `df3` => delete forward to next occurrence of 3
    // 
    // Alternately, `f,dt)` would also work!  "find the next comma, delete till next occurrence of )"
    // ci( is easiest if the goal is recomposing the params entirely. "change IN ("
    public void Baz(int arg1, int arg2, int arg3)
    {

    }
}



