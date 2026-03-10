# apbd-tut-01
The merge was not fast-forward as the history of commits was not linear because the main branch was changed after creating a feature-min branch|

1. When does Git perform a fast-forward and when is a merge commit created? Fast-forward is performed when the history of comments could be seen as linear. A merge commit is created when there are new commits in both branches(e.g. main and additional) after the branches diverged.
2. What is the practical difference between merge and rebase? Merge keeps the history of commits as it is (with branches diverging from the main and merging into main) and rebase rewrites the history so that it seems like commits were made in the same branch linearly
3. How was the conflict resolved in your repository? I accepted lines from both branches placing them one after another
