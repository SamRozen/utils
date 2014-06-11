#!/bin/bash
find -E . -regex ".*\.json|.*\.js|.*\.pp|.*\.m|.*\.py|.*\.conf|.*\.proto|.*\.c|.*\.cc|.*\.cpp|.*\.h|.*\.java|.*\.scala|.*\.el" | xargs grep -i $*
