#!/bin/bash
find -E . -regex ".*\.clj|.*\.avsc|.*\.json|.*\.js|.*\.pp|.*\.m|.*\.py|.*\.conf|.*\.proto|.*\.c|.*\.cc|.*\.cpp|.*\.h|.*\.java|.*\.scala|.*\.el|.*\.xml" | xargs grep -i $*
