#!/usr/bin/env bash

set -Eeuo pipefail
trap clean_up SIGINT SIGTERM ERR EXIT

function clean_up {
  exit 0
}

dotnet publish -c Release -o ./publish/app
