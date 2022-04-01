FROM ubuntu:20.04
RUN apt update \
&& apt install -y python3 fortune
ADD PaperROG /game/
EXPOSE 19
CMD [ "python3", "-m", "http.server", "-d","/game/", "19" ]

