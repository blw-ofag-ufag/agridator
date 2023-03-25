# agridator
GovTech Hackathon Challenge agridator

## Deploy to GitHub Pages
```
cd agridator-frontend
git checkout gh-pages
git pull
git merge origin/main
ng build --output-path ../docs --base-href /agridator/
cp ../docs/index.html ../docs/404.html
```
https://gerhardfurrer.github.io/agridator
