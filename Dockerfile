FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr

WORKDIR /FlatplanRenderer

ADD ./src/FlatplanRenderer/ . 

RUN dnu restore --no-cache && \
    dnu publish . -o ../app --configuration Release --no-source --include-symbols && \
    cd .. && \
    rm -rf FlatplanRenderer
  
EXPOSE 5000
CMD /app/approot/web