docker run --rm -d -p 8888:8888 -v ${PWD}:/home/jovyan/pwd --name ihaskell_notebook crosscompass/ihaskell-notebook:latest jupyter lab --LabApp.token=''