import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // Adicione esta linha
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms'; // Importar FormsModule
import { AppComponent } from './app.component';
import { LivrosListComponent } from './livros-list/livros-list.component';
import { LivroFormComponent } from './livro-form/livro-form.component';

@NgModule({
  declarations: [
    AppComponent,
    LivrosListComponent,
    LivroFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    // Adicione esta linha
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
