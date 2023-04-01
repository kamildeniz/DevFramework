import { Component } from '@angular/core';
import { IMovie } from './movie';
import { MovieService } from './movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: [ './movie-list.component.css' ],
})
export class MovieListComponent {
  favoriteHero: string | undefined;
  showImage = false;
  movies: IMovie[];

  constructor(movieService: MovieService) {
    this.movies = movieService.getMovies();
  }

  toggleImage(): void {
    this.showImage = !this.showImage;
  }

  checkMovieHero(value: string): boolean {
    return this.movies.filter(movie => movie.hero === value).length > 0 ;
  }
}
