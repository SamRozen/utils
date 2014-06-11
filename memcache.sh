#!/bin/bash

metric='get_misses'
if [ $# -gt 0 ]; then
    metric=$1
fi

last=$(echo -e 'stats\nquit' | nc localhost 11211 | grep ${metric} | awk '{print $3}' | tr '\r' ' ')
while [ 1 ]; do
    curr=$(echo -e 'stats\nquit' | nc localhost 11211 | grep ${metric} | awk '{print $3}' | tr '\r' ' ')
    rate=$(expr ${curr} - ${last})
    echo "${metric}: ${rate}/sec"
    last=${curr}
    sleep 1
done
