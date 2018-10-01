// Filters and the expression register are two really cool ways of calling arbitrary code from vim.

// Filters are just anything that takes your text via stdin and gives you something via stdout
// Filters can be invoked via `!{motion}` or `!` while selecting, and can call arbitrary scripts
// Examples with either `!}` or `v}!`:
//   - !grep cat
//   - !sed s/dog/cat/
//   - !sed s/cat/dog/
//   - !echo foo
// 
// This works with arbitrary scripts (do_stuff_to_my_code.sh, print_funny_comment.sh, etc) as well!

let s1 = "The quick brown fox jumps over the lazy dog";
let s2 = "The quick brown fox jumps over the lazy dog";
let s3 = "The quick brown fox jumps over the lazy cat";
let s4 = "The quick brown fox jumps over the lazy dog";

