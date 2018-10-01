using System;
public class MoveOpRepeat
{
    // Vim has many normal mode keys to easte the pains of repetition, but `.` is
    // the one that is (probably) used most often.  `.` will repeat the last
    // "action" taken. Some quick examples of what counts as "one action":
    //  - dropping into insert mode to insert text
    //  - `dd`, deleting a line
    //  - `di"`, deleting inner quotes
    //  - `cit`, changing inner tags
    //  - `O`, insert one empty line above current one



    // Suppose you have a series of function calls, all of which took one parameter
    // which is a string.  You are refactoring the code, and have decided that you
    // can and no longer need the string as a parameter.

    // One very quick way to do it would be:
    // `f(di(j.j.j.`
    //  - `f(` => forward to next occurrence of (
    //  - `di(` => delete inner (
    //  - `j.` => move down, repeat last action
    public MoveOpRepeat()
    {
        var v1 = Foo("bar 1");
        var v2 = Foo("bar 2");
        var v3 = Foo("bar 3");
        var v4 = Foo("foo 4");
    }

    private void Foo(string bar)
    {
        return $"{bar}baz";
    }

    // A new teammate really loves params, but forgot datatypes
    // `fliDateTime<Space><Esc>lW.W.W.W.`
    //  - `fl` => forward to next occurrence of l
    //  - iDateTime<Space><Esc> 
    //        => append 'DateTime ' at the cursor, drop back to Normal mode
    //  - `W` => move to next WORD (WORD is delimited only by space, word can be delimited by punctuation as well) 
    //  - `.` => Repeat last action
    private void Bar(l, m, n, o, p)
    {

    }

    // You are fixing a PR for your friend who doesn't know what semicolons are.
    // first step is to insert semi-colons at the ends of lines.
    // `A;<Esc>j.j.`
    //  - `A;<Esc>` => Append colon at the end of line, drop back to Normal mode
    //  - `j.` => move down, repeat last action
    public void ClearlyWrittenByMe()
    {
        var v1 = Foo("bar 1")
        var v2 = Foo("bar 222237")
        var v3 = v1 + v2
    }
}



