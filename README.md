# C# Mad-libs
A mad-libs clone written as a C# dotnet console application

# How It Works
All the madlibs are in the `madlibs.txt` file. It's quite simple, in fact, is I made this within a hour. A mad-lib sentence ready to be assembled looks like this in the file:

```
I was {verb,ing} the waves until a(n) {noun} came and {adverb} {verb,ed} my {noun}
```

If it's a lib, it'll ask for the player:
* `{verb}` is for a verb *(drink, swim, jump)*
* `{verb,ing}` is for a verb in past tense *(drank, swam, jumped)*
* `{verb,en}` is for a verb in present tense *drinking, swimming, jumping*
* `{noun}` is for a noun *(cat, book, bullet)*
* `{pluralnoun}` is for a plural noun *(cats, books, bullets)*
* `{propernoun}` is for a proper noun *(Doe, Pete's Pizza, The Book of Thousand Truths)*
* `{abjective}` is for an abjective *(unpleasing, depressed, bewildering)*
* `{adverb}` is for an adverb *(quickly, quietly, brutally)*

Go ahead and make your mad-lib sentence and convert libs into these. If you need an example, why not try this sentence:

```
The shark tried hard to get Jen the Jellyfish to sign his dubious contract.
```