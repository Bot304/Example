/// <binding Clean='clean' />
//"use strict";

//var gulp = require("gulp"),
//    sass = require("gulp-sass"); // добавляем модуль sass

//var paths = {
//    webroot: "./wwwroot/"
//};
//// регистрируем задачу для конвертации файла scss в css
//gulp.task("sass", function () {
//    return gulp.src('Sass/Styles.scss')
//        .pipe(sass())
//        .pipe(gulp.dest(paths.webroot + '/css'));
//});

'use strict';

var _require = require('gulp');

var src = _require.src;
var dest = _require.dest;
var watch = _require.watch;

var sass = require('gulp-sass');
var browserSync = require('browser-sync').create();
var gulpStylelint = requare('gulp-stylelint');

function style() {
    return src('./css/**/*.scss').pipe(gulpStylelint({
        reporters: [{
            formatter: 'string',
            console: true
        }]
    })).pipe(sass().on('error', sass.logError)).pipe(dest('./css/')).pipe(browserSync.stream());
}

function watcher() {
    browserSync.init({
        server: {
            baseDir: './'
        }
    });
    watch('./css/**/*.scss', style);
    watch('./*.html').on('change', browserSync.reload);
    watch('./js/**/*.js').on('change', browserSync.reload);
}

exports.style = style;
exports.watch = watcher;

