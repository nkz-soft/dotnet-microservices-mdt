#!/usr/bin/env bash

set -Eeuo pipefail
trap clean_up SIGINT SIGTERM ERR EXIT

function clean_up {
  exit 0
}

declare BUILD_MODULES="NKZSoft.Gateway.Service NKZSoft.Catalog.Service \
         NKZSoft.Order.Service NKZSoft.Payment.Service \
         NKZSoft.Bucket.Service"

if [ -n "$BUILD_MODULES" ]; then
    for build_module in $BUILD_MODULES; do
        (cd ./../../src/$build_module && dotnet publish -c Release -o ./publish/app)
    done
fi
