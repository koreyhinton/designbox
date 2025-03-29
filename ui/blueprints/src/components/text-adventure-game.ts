import { html, LitElement } from "lit";
import { customElement, property } from "lit/decorators.js";
import "./text-adventure-game-shell";

@customElement("text-adventure-game")
export class TextAdventureGame extends LitElement {

  @property({ type: Number }) accessor sceneIndex: number = 1;

  render() {
    return html`
      <div scene>
        <label for="room">Room #</label><input name="room" type="number" min="1" max="3" value="2" @change=${(e)=>{
        this.sceneIndex = parseInt(e.target.value);
    }}/>
      </div>
      <text-adventure-game-shell .sceneIndex=${this.sceneIndex}></text-adventure-game-shell>
    `;
  }

}
