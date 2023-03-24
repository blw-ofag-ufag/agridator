# agridator
GovTech Hackathon Challenge agridator

## Deploy to GitHub Pages
- npm run test
- test manual
```
cd agridator-frontend
git checkout gh-pages
git pull
git merge origin/main
ng build --output-path ../docs --base-href /agridator/
cp ../docs/index.html ../docs/404.html
```
- commit and push
- git checkout main
